#SqlAuditor#
**SqlAuditor is a simple yet powerful auditor for MS SQL Server.**


**Please feel free to contact me for any help, issues or suggestions.**

----------

###Downloads###

[SqlAuditor Downloads](https://github.com/iraklisk/SqlAuditor/releases)



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

###Documentation###

**Please check out our [Wiki](http://github.com/iraklisk/SqlAuditor/wiki) for installation and usage documentation.**

----------


### Screenshots


![Screenshot 1](https://cloud.githubusercontent.com/assets/12159215/7501020/04b16dae-f43a-11e4-8b5a-e1667cd23836.png)
![Screenshot 2](https://cloud.githubusercontent.com/assets/12159215/7501122/a6bee676-f43a-11e4-8457-89b2ca33cf24.png)
![Screenshot 3](https://cloud.githubusercontent.com/assets/12159215/7501124/a6cbddcc-f43a-11e4-8dce-646ef45cab00.png)
![Screenshot 4](https://cloud.githubusercontent.com/assets/12159215/7501125/a6d25d46-f43a-11e4-9952-c8cc6af46974.png)
![Screenshot 5](https://cloud.githubusercontent.com/assets/12159215/7501123/a6c603c0-f43a-11e4-93c0-56b6921a2258.png)
![Screenshot 6](https://cloud.githubusercontent.com/assets/12159215/7501211/280ff2a6-f43b-11e4-913b-49007074cb9b.png)
![Screenshot 7](https://cloud.githubusercontent.com/assets/12159215/7501212/283139f2-f43b-11e4-9516-7bc1d8183072.png)
![Screenshot 8](https://cloud.githubusercontent.com/assets/12159215/7501213/283a344e-f43b-11e4-9c46-5106bfdff321.png)
![Screenshot 9](https://cloud.githubusercontent.com/assets/12159215/7501214/283f4830-f43b-11e4-953e-87d4c63c96e9.png)
![Screenshot 10](https://cloud.githubusercontent.com/assets/12159215/7501215/28446158-f43b-11e4-8367-0aa91f3ba698.png)



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


