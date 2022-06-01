# Performance improvements approaches demo

Ths repository is dedicated for performing comparison of semi identical solutions with some key distinctions in order to investigate influence on such destinctions on solution performance.

Repository consist of `Solution` folder, containing folders with scenarious. At the root there is `docker-compose.yaml` file, containing all required dependencies. Each folder contains several projects for comparison, optional `Reusables` project and `LoadTest` project with NBomber load test scenario.

Also repository contains `Testing-Notes` folder, containing collected testing results for projects. Results collected with NBomber reports, dotnet counters and PerfView.  