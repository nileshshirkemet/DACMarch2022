
//  Microsoft (R) .NET IL Disassembler.  Version 6.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 6:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 6:0:0:0
}
.assembly DemoApp
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 36 2E 30 01 00 54 0E 14   // ersion=v6.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 44 65 6D 6F 41 70 70 00 00 )             // ...DemoApp..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module DemoApp.dll
// MVID: {F15BBA5F-1552-47D2-B229-0B9C58ED35D7}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x000001CD32E40000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Interval
       extends [System.Runtime]System.Object
{
  .field private initonly int32 '<Minutes>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private initonly int32 '<Seconds>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Minutes() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Minutes>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Minutes

  .method public hidebysig specialname instance int32 
          get_Seconds() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Interval::'<Seconds>k__BackingField'
    IL_0006:  ret
  } // end of method Interval::get_Seconds

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 min,
                               int32 sec) cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  ldarg.2
    IL_000b:  ldc.i4.s   60
    IL_000d:  div
    IL_000e:  add
    IL_000f:  stfld      int32 Interval::'<Minutes>k__BackingField'
    IL_0014:  ldarg.0
    IL_0015:  ldarg.2
    IL_0016:  ldc.i4.s   60
    IL_0018:  rem
    IL_0019:  stfld      int32 Interval::'<Seconds>k__BackingField'
    IL_001e:  ret
  } // end of method Interval::.ctor

  .method public hidebysig instance int32 
          Time() cil managed
  {
    // Code size       22 (0x16)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldc.i4.s   60
    IL_0003:  ldarg.0
    IL_0004:  call       instance int32 Interval::get_Minutes()
    IL_0009:  mul
    IL_000a:  ldarg.0
    IL_000b:  call       instance int32 Interval::get_Seconds()
    IL_0010:  add
    IL_0011:  stloc.0
    IL_0012:  br.s       IL_0014

    IL_0014:  ldloc.0
    IL_0015:  ret
  } // end of method Interval::Time

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       99 (0x63)
    .maxstack  3
    .locals init (bool V_0,
             int32 V_1,
             string V_2)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance int32 Interval::get_Seconds()
    IL_0007:  ldc.i4.s   10
    IL_0009:  clt
    IL_000b:  stloc.0
    IL_000c:  ldloc.0
    IL_000d:  brfalse.s  IL_0038

    IL_000f:  ldarg.0
    IL_0010:  call       instance int32 Interval::get_Minutes()
    IL_0015:  stloc.1
    IL_0016:  ldloca.s   V_1
    IL_0018:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_001d:  ldstr      ":0"
    IL_0022:  ldarg.0
    IL_0023:  call       instance int32 Interval::get_Seconds()
    IL_0028:  stloc.1
    IL_0029:  ldloca.s   V_1
    IL_002b:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0030:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_0035:  stloc.2
    IL_0036:  br.s       IL_0061

    IL_0038:  ldarg.0
    IL_0039:  call       instance int32 Interval::get_Minutes()
    IL_003e:  stloc.1
    IL_003f:  ldloca.s   V_1
    IL_0041:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0046:  ldstr      ":"
    IL_004b:  ldarg.0
    IL_004c:  call       instance int32 Interval::get_Seconds()
    IL_0051:  stloc.1
    IL_0052:  ldloca.s   V_1
    IL_0054:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0059:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_005e:  stloc.2
    IL_005f:  br.s       IL_0061

    IL_0061:  ldloc.2
    IL_0062:  ret
  } // end of method Interval::ToString

  .method public hidebysig virtual instance int32 
          GetHashCode() cil managed
  {
    // Code size       19 (0x13)
    .maxstack  2
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  call       instance int32 Interval::get_Minutes()
    IL_0007:  ldarg.0
    IL_0008:  call       instance int32 Interval::get_Seconds()
    IL_000d:  add
    IL_000e:  stloc.0
    IL_000f:  br.s       IL_0011

    IL_0011:  ldloc.0
    IL_0012:  ret
  } // end of method Interval::GetHashCode

  .method public hidebysig virtual instance bool 
          Equals(object other) cil managed
  {
    // Code size       57 (0x39)
    .maxstack  2
    .locals init (class Interval V_0,
             bool V_1,
             bool V_2)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  isinst     Interval
    IL_0007:  stloc.0
    IL_0008:  ldloc.0
    IL_0009:  ldnull
    IL_000a:  cgt.un
    IL_000c:  stloc.1
    IL_000d:  ldloc.1
    IL_000e:  brfalse.s  IL_0033

    IL_0010:  nop
    IL_0011:  ldarg.0
    IL_0012:  call       instance int32 Interval::get_Minutes()
    IL_0017:  ldloc.0
    IL_0018:  callvirt   instance int32 Interval::get_Minutes()
    IL_001d:  bne.un.s   IL_002f

    IL_001f:  ldarg.0
    IL_0020:  call       instance int32 Interval::get_Seconds()
    IL_0025:  ldloc.0
    IL_0026:  callvirt   instance int32 Interval::get_Seconds()
    IL_002b:  ceq
    IL_002d:  br.s       IL_0030

    IL_002f:  ldc.i4.0
    IL_0030:  stloc.2
    IL_0031:  br.s       IL_0037

    IL_0033:  ldc.i4.0
    IL_0034:  stloc.2
    IL_0035:  br.s       IL_0037

    IL_0037:  ldloc.2
    IL_0038:  ret
  } // end of method Interval::Equals

  .method public hidebysig specialname static 
          class Interval  op_Addition(class Interval lhs,
                                      class Interval rhs) cil managed
  {
    // Code size       37 (0x25)
    .maxstack  3
    .locals init (class Interval V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  callvirt   instance int32 Interval::get_Minutes()
    IL_0007:  ldarg.1
    IL_0008:  callvirt   instance int32 Interval::get_Minutes()
    IL_000d:  add
    IL_000e:  ldarg.0
    IL_000f:  callvirt   instance int32 Interval::get_Seconds()
    IL_0014:  ldarg.1
    IL_0015:  callvirt   instance int32 Interval::get_Seconds()
    IL_001a:  add
    IL_001b:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0020:  stloc.0
    IL_0021:  br.s       IL_0023

    IL_0023:  ldloc.0
    IL_0024:  ret
  } // end of method Interval::op_Addition

  .property instance callconv(8) int32 Minutes()
  {
    .get instance int32 Interval::get_Minutes()
  } // end of property Interval::Minutes
  .property instance callconv(8) int32 Seconds()
  {
    .get instance int32 Interval::get_Seconds()
  } // end of property Interval::Seconds
} // end of class Interval

.class private auto ansi beforefieldinit Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Print(string label,
                                               object info) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "{0} = {1}"
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object,
                                                                        object)
    IL_000d:  nop
    IL_000e:  ret
  } // end of method Program::Print

  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       412 (0x19c)
    .maxstack  3
    .locals init (class Interval V_0,
             class Interval V_1,
             class Interval V_2,
             class Interval V_3,
             valuetype Rectangle V_4,
             float64 V_5,
             string V_6)
    IL_0000:  nop
    IL_0001:  ldc.i4.6
    IL_0002:  ldc.i4.s   10
    IL_0004:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0009:  stloc.0
    IL_000a:  ldc.i4.3
    IL_000b:  ldc.i4.5
    IL_000c:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_0011:  stloc.1
    IL_0012:  ldc.i4.5
    IL_0013:  ldc.i4.s   70
    IL_0015:  newobj     instance void Interval::.ctor(int32,
                                                       int32)
    IL_001a:  stloc.2
    IL_001b:  ldloc.1
    IL_001c:  stloc.3
    IL_001d:  ldstr      "Interval a"
    IL_0022:  ldloc.0
    IL_0023:  call       void Program::Print(string,
                                             object)
    IL_0028:  nop
    IL_0029:  ldstr      "Interval b"
    IL_002e:  ldloc.1
    IL_002f:  call       void Program::Print(string,
                                             object)
    IL_0034:  nop
    IL_0035:  ldstr      "Interval c"
    IL_003a:  ldloc.2
    IL_003b:  call       void Program::Print(string,
                                             object)
    IL_0040:  nop
    IL_0041:  ldstr      "Interval d"
    IL_0046:  ldloc.3
    IL_0047:  call       void Program::Print(string,
                                             object)
    IL_004c:  nop
    IL_004d:  ldstr      "Total"
    IL_0052:  ldloc.0
    IL_0053:  ldloc.1
    IL_0054:  call       class Interval Interval::op_Addition(class Interval,
                                                              class Interval)
    IL_0059:  ldloc.2
    IL_005a:  call       class Interval Interval::op_Addition(class Interval,
                                                              class Interval)
    IL_005f:  ldloc.3
    IL_0060:  call       class Interval Interval::op_Addition(class Interval,
                                                              class Interval)
    IL_0065:  call       void Program::Print(string,
                                             object)
    IL_006a:  nop
    IL_006b:  ldstr      "---------------------------"
    IL_0070:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0075:  nop
    IL_0076:  ldstr      "a is identical to b: {0}"
    IL_007b:  ldloc.0
    IL_007c:  ldloc.1
    IL_007d:  ceq
    IL_007f:  box        [System.Runtime]System.Boolean
    IL_0084:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0089:  nop
    IL_008a:  ldstr      "a is identical to c: {0}"
    IL_008f:  ldloc.0
    IL_0090:  ldloc.2
    IL_0091:  ceq
    IL_0093:  box        [System.Runtime]System.Boolean
    IL_0098:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_009d:  nop
    IL_009e:  ldstr      "d is identical to b: {0}"
    IL_00a3:  ldloc.3
    IL_00a4:  ldloc.1
    IL_00a5:  ceq
    IL_00a7:  box        [System.Runtime]System.Boolean
    IL_00ac:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00b1:  nop
    IL_00b2:  ldstr      "---------------------------"
    IL_00b7:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00bc:  nop
    IL_00bd:  ldstr      "a is equal to b: {0}"
    IL_00c2:  ldloc.0
    IL_00c3:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00c8:  ldloc.1
    IL_00c9:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00ce:  bne.un.s   IL_00d9

    IL_00d0:  ldloc.0
    IL_00d1:  ldloc.1
    IL_00d2:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_00d7:  br.s       IL_00da

    IL_00d9:  ldc.i4.0
    IL_00da:  box        [System.Runtime]System.Boolean
    IL_00df:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_00e4:  nop
    IL_00e5:  ldstr      "a is equal to c: {0}"
    IL_00ea:  ldloc.0
    IL_00eb:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00f0:  ldloc.2
    IL_00f1:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_00f6:  bne.un.s   IL_0101

    IL_00f8:  ldloc.0
    IL_00f9:  ldloc.2
    IL_00fa:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_00ff:  br.s       IL_0102

    IL_0101:  ldc.i4.0
    IL_0102:  box        [System.Runtime]System.Boolean
    IL_0107:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_010c:  nop
    IL_010d:  ldstr      "d is equal to b: {0}"
    IL_0112:  ldloc.3
    IL_0113:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_0118:  ldloc.1
    IL_0119:  callvirt   instance int32 [System.Runtime]System.Object::GetHashCode()
    IL_011e:  bne.un.s   IL_0129

    IL_0120:  ldloc.3
    IL_0121:  ldloc.1
    IL_0122:  callvirt   instance bool [System.Runtime]System.Object::Equals(object)
    IL_0127:  br.s       IL_012a

    IL_0129:  ldc.i4.0
    IL_012a:  box        [System.Runtime]System.Boolean
    IL_012f:  call       void [System.Console]System.Console::WriteLine(string,
                                                                        object)
    IL_0134:  nop
    IL_0135:  ldstr      "---------------------------"
    IL_013a:  call       void [System.Console]System.Console::WriteLine(string)
    IL_013f:  nop
    IL_0140:  ldloca.s   V_4
    IL_0142:  ldc.r4     15.
    IL_0147:  stfld      float32 Rectangle::Length
    IL_014c:  ldloca.s   V_4
    IL_014e:  ldc.r4     12.
    IL_0153:  stfld      float32 Rectangle::Breadth
    IL_0158:  ldstr      "Rectangle e"
    IL_015d:  ldloc.s    V_4
    IL_015f:  box        Rectangle
    IL_0164:  call       void Program::Print(string,
                                             object)
    IL_0169:  nop
    IL_016a:  ldc.r8     4.5
    IL_0173:  stloc.s    V_5
    IL_0175:  ldstr      "Double f"
    IL_017a:  ldloc.s    V_5
    IL_017c:  box        [System.Runtime]System.Double
    IL_0181:  call       void Program::Print(string,
                                             object)
    IL_0186:  nop
    IL_0187:  ldstr      "Monday"
    IL_018c:  stloc.s    V_6
    IL_018e:  ldstr      "String g"
    IL_0193:  ldloc.s    V_6
    IL_0195:  call       void Program::Print(string,
                                             object)
    IL_019a:  nop
    IL_019b:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class Program

.class private sequential ansi sealed beforefieldinit Rectangle
       extends [System.Runtime]System.ValueType
{
  .field public float32 Length
  .field public float32 Breadth
  .method public hidebysig instance float64 
          Area() cil managed
  {
    // Code size       20 (0x14)
    .maxstack  2
    .locals init (float64 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      float32 Rectangle::Length
    IL_0007:  ldarg.0
    IL_0008:  ldfld      float32 Rectangle::Breadth
    IL_000d:  mul
    IL_000e:  conv.r8
    IL_000f:  stloc.0
    IL_0010:  br.s       IL_0012

    IL_0012:  ldloc.0
    IL_0013:  ret
  } // end of method Rectangle::Area

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       38 (0x26)
    .maxstack  3
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "{0} x {1}"
    IL_0006:  ldarg.0
    IL_0007:  ldfld      float32 Rectangle::Length
    IL_000c:  box        [System.Runtime]System.Single
    IL_0011:  ldarg.0
    IL_0012:  ldfld      float32 Rectangle::Breadth
    IL_0017:  box        [System.Runtime]System.Single
    IL_001c:  call       string [System.Runtime]System.String::Format(string,
                                                                      object,
                                                                      object)
    IL_0021:  stloc.0
    IL_0022:  br.s       IL_0024

    IL_0024:  ldloc.0
    IL_0025:  ret
  } // end of method Rectangle::ToString

} // end of class Rectangle


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
