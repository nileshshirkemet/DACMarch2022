
//  Microsoft (R) .NET IL Disassembler.  Version 6.0.0



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 6:0:0:0
}
.assembly FinLib
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
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 06 46 69 6E 4C 69 62 00 00 )                // ...FinLib..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 06 46 69 6E 4C 69 62 00 00 )                // ...FinLib..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 06 46 69 6E 4C 69 62 00 00 )                // ...FinLib..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module FinLib.dll
// MVID: {3E19C9E6-4E8F-4BBE-8594-274D15C29258}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x000002415B400000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit Finance.EducationLoan
       extends [System.Runtime]System.Object
{
  .method public hidebysig instance float32 
          Common(float64 amount,
                 int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 05 00 00 00 00 00 ) 
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldc.r4     6.
    IL_0005:  ret
  } // end of method EducationLoan::Common

  .method public hidebysig instance float32 
          Masters(float64 amount,
                  int32 period) cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldc.r4     7.
    IL_0005:  ret
  } // end of method EducationLoan::Masters

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EducationLoan::.ctor

} // end of class Finance.EducationLoan

.class public auto ansi beforefieldinit Finance.HomeLoan
       extends [System.Runtime]System.Object
{
  .method public hidebysig instance float32 
          Common(float64 amount,
                 int32 period) cil managed
  {
    // Code size       17 (0x11)
    .maxstack  8
    IL_0000:  ldarg.2
    IL_0001:  ldc.i4.5
    IL_0002:  blt.s      IL_000b

    IL_0004:  ldc.r4     8.5
    IL_0009:  br.s       IL_0010

    IL_000b:  ldc.r4     9.
    IL_0010:  ret
  } // end of method HomeLoan::Common

  .method public hidebysig instance float32 
          Woman(float64 amount,
                int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 0C 00 00 00 00 00 ) 
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       instance float32 Finance.HomeLoan::Common(float64,
                                                                   int32)
    IL_0008:  ldc.r4     1.
    IL_000d:  sub
    IL_000e:  ret
  } // end of method HomeLoan::Woman

  .method public hidebysig instance float32 
          Soldier(float64 amount,
                  int32 period) cil managed synchronized
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  call       instance float32 Finance.HomeLoan::Common(float64,
                                                                   int32)
    IL_0008:  ldc.r4     4.
    IL_000d:  sub
    IL_000e:  ret
  } // end of method HomeLoan::Soldier

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method HomeLoan::.ctor

} // end of class Finance.HomeLoan

.class public auto ansi beforefieldinit Finance.MaxDurationAttribute
       extends [System.Runtime]System.Attribute
{
  .custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = ( 01 00 40 00 00 00 00 00 )                         // ..@.....
  .field private int32 '<Limit>k__BackingField'
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Limit() cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 Finance.MaxDurationAttribute::'<Limit>k__BackingField'
    IL_0006:  ret
  } // end of method MaxDurationAttribute::get_Limit

  .method public hidebysig specialname instance void 
          set_Limit(int32 'value') cil managed
  {
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 Finance.MaxDurationAttribute::'<Limit>k__BackingField'
    IL_0007:  ret
  } // end of method MaxDurationAttribute::set_Limit

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor([opt] int32 limit) cil managed
  {
    .param [1] = int32(0x00000005)
    // Code size       17 (0x11)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  call       instance void Finance.MaxDurationAttribute::set_Limit(int32)
    IL_000f:  nop
    IL_0010:  ret
  } // end of method MaxDurationAttribute::.ctor

  .property instance callconv(8) int32 Limit()
  {
    .get instance int32 Finance.MaxDurationAttribute::get_Limit()
    .set instance void Finance.MaxDurationAttribute::set_Limit(int32)
  } // end of property MaxDurationAttribute::Limit
} // end of class Finance.MaxDurationAttribute

.class public auto ansi beforefieldinit Finance.PersonalLoan
       extends [System.Runtime]System.Object
{
  .method public hidebysig instance float32 
          Common(float64 amount,
                 int32 period) cil managed
  {
    .custom instance void Finance.MaxDurationAttribute::.ctor(int32) = ( 01 00 05 00 00 00 01 00 54 08 05 4C 69 6D 69 74   // ........T..Limit
                                                                         06 00 00 00 ) 
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldc.r4     10.
    IL_0005:  ldc.r4     0.5
    IL_000a:  ldarg.2
    IL_000b:  conv.r4
    IL_000c:  mul
    IL_000d:  add
    IL_000e:  ret
  } // end of method PersonalLoan::Common

  .method public hidebysig instance float32 
          Employee(float64 amount,
                   int32 period) cil managed
  {
    // Code size       34 (0x22)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  ldc.r8     600000.
    IL_000a:  blt.s      IL_0013

    IL_000c:  ldc.r4     8.
    IL_0011:  br.s       IL_0021

    IL_0013:  ldarg.0
    IL_0014:  ldarg.1
    IL_0015:  ldarg.2
    IL_0016:  call       instance float32 Finance.PersonalLoan::Common(float64,
                                                                       int32)
    IL_001b:  ldc.r4     2.
    IL_0020:  div
    IL_0021:  ret
  } // end of method PersonalLoan::Employee

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method PersonalLoan::.ctor

} // end of class Finance.PersonalLoan


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
