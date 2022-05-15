> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `76.7`, mean = `238.46`, max = `419.1`, StdDev = `55.85`|
|latency percentile|50% = `240.13`, 75% = `277.5`, 95% = `331.01`, 99% = `367.36`|
> status codes for scenario: `Orders`

|status code|count|message|
|---|---|---|
|200|2700||

> scenario: `Products`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `20.05`, mean = `102.17`, max = `335.1`, StdDev = `29.94`|
|latency percentile|50% = `101.12`, 75% = `121.09`, 95% = `145.79`, 99% = `176.13`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2700||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
