> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `51.79`, mean = `206.65`, max = `383.5`, StdDev = `59.62`|
|latency percentile|50% = `206.34`, 75% = `247.68`, 95% = `303.62`, 99% = `346.62`|
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
|latency|min = `24.84`, mean = `75.17`, max = `247.56`, StdDev = `20.09`|
|latency percentile|50% = `73.41`, 75% = `87.62`, 95% = `109.25`, 99% = `124.42`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2700||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
