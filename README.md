#SqlAuditor#
**SqlAuditor is a simple yet powerful auditor for MS SQL Server.**

I created SqlAuditor because we needed a solution to audit privileged accounts for ISO-27001 and SOLVENCY.

**Please feel free to contact me for any help, issues or suggestions.**



----------



###SqlAuditor features###
 1. Audit multiple MS SQL Server instances.
 2. Persists audit events.
 3. Support Both SQL Server Authentication/Windows Authentication.
 4. Events,Columns and Filter per SQL Server instances.
 5. Email notification for selected events.
 7. Runs as a service.
 8. Easy GUI for Configuration, Testing and Reporting.
 9. Export audit events to Microsoft Excel and PDF.


----------

###Releases###

[SqlAuditor Downloads](https://github.com/iraklisk/SqlAuditor/releases)

----------

###Documentation###

**Please check out our [Wiki](http://github.com/iraklisk/SqlAuditor/wiki) for installation and usage documentation.**

----------



###Technical Details  ###

SqlAuditor is essential a persistent profiler for MS SQL Server based on the excellent Open Source project [ExpressProfiler](http://expressprofiler.codeplex.com).

SqlAuditor is devided in 4 different projects.

1. SqlAuditor is the core library.
2. SqlAuditor.Console is a console host.
3. SqlAuditor.Service is a service host.
4. SqlAuditor.Win is the GUI used for creating the configuration files, testing configuration files, viewing and exporting the logs.

The configuration consist of 2 files:

1. Config.xml (Serialized config classes)
2. Key.txt (Contains a unique machine id generated to encrypt passwords)



----------



### License ###

The MIT License (MIT)

Copyright (c) 2015 Iraklis Karagkiozoglou

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


