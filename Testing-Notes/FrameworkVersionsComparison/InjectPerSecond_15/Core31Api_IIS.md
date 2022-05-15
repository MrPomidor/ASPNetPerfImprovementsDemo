> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2675`, fail count: `25`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2675`, RPS = `14.9`|
|latency|min = `53.5`, mean = `292.16`, max = `735.89`, StdDev = `81.97`|
|latency percentile|50% = `302.08`, 75% = `341.5`, 95% = `422.14`, 99% = `499.46`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, fail = `25`, RPS = `0.1`|
|latency|min = `1005.65`, mean = `1019.57`, max = `1028.74`, StdDev = `8.3`|
|latency percentile|50% = `1025.02`, 75% = `1026.56`, 95% = `1027.58`, 99% = `1029.12`|
> status codes for scenario: `Orders`

|status code|count|message|
|---|---|---|
|200|2675||
|-100|25|step timeout|

> scenario: `Products`, duration: `00:03:00`, ok count: `2686`, fail count: `14`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `2700`, ok = `2686`, RPS = `14.9`|
|latency|min = `14.3`, mean = `103.72`, max = `509.33`, StdDev = `37.01`|
|latency percentile|50% = `103.3`, 75% = `120.7`, 95% = `150.91`, 99% = `188.29`|

|step|fail stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `2700`, fail = `14`, RPS = `0.1`|
|latency|min = `1023.15`, mean = `1024.73`, max = `1025.87`, StdDev = `0.85`|
|latency percentile|50% = `1025.02`, 75% = `1025.54`, 95% = `1026.05`, 99% = `1026.05`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2686||
|-100|14|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
