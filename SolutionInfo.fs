﻿namespace System
open System.Reflection

[<assembly: AssemblyProductAttribute("Alea TK")>]
[<assembly: AssemblyCompanyAttribute("QuantAlea AG.")>]
[<assembly: AssemblyCopyrightAttribute("QuantAlea AG. 2016-2016")>]
[<assembly: AssemblyVersionAttribute("0.9.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.9.0.2")>]
[<assembly: AssemblyInformationalVersionAttribute("0.9.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.9.0.2"
    let [<Literal>] InformationalVersion = "0.9.0.2"
