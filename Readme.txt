environment: C#, Visual Studio recommended

"Hello World" example for FundsXML (smallest possible XML based on FundsXML xsdfile generated).

Details for FundsXML can be found under http://www.fundsxml.org

1 C# file is generated from xsdfile by xsd.exe program.

The code manually written can be found in src/fundsXML/Main.java

A real world example would have to fetch all data for security types, probably from a database. 

According to schema file these are the possible security types:
EQ = equity
BO = bond
FU = fund
DE = derivative
FE = foreign exchange dates
IN = index certificates
SW = swap
AC = accounts
FT = fixed deposit
CM = call capital (?)
RE = Real Estate
CB = Convertible Bond
CS = Credit Default Swap
IX = Index
RP = repo
BM = Benchmark

