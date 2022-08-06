using System.Text;
using System.Runtime.InteropServices;

unsafe class Program
{
    private static double AddSquares(double[] values)
    {
        double total = 0;
        double* pSum = &total; //taking the address of a value on stack
        //to take the address of a value within an object on the heap
        //this object must be pinned (using fixed statement) so that it
        //is not moved from its current location during garbage collection
        fixed(double* pVal = &values[0])
        {
            for(int i = 0; i < values.Length; ++i)
                *pSum += pVal[i] * pVal[i];
        }
        return total;
    }

    //the implementation of a static method defined with extern modifier is imported
    //from a native function (entry-point) exported by a dynamically linked library (DLL)
    //identfied by DllImport attribute applied to that methpd
    [DllImport("legacy", EntryPoint="encrypt_buffer")]
    private extern static long EncryptData(byte[] bytes, int count, string key, delegate*<byte, byte, int> transform);

    private static int XorEncode(byte a, byte b) => a ^ b;

    public static void Main(string[] args)
    {
        if(args.Length > 1)
        {
            double[] values = args.Select(double.Parse).ToArray();
            Console.WriteLine("Sum of Squares = {0:0.000}", AddSquares(values));
        }
        else
        {
            byte[] data = Encoding.UTF8.GetBytes(args[0]);
            long hs = EncryptData(data, data.Length, "#", &XorEncode);
            string text = Encoding.UTF8.GetString(data);
            Console.WriteLine("Encrypted Text: {0}", text);
            Console.WriteLine("Signature Code: {0:X}", hs);
        }
    }
}
