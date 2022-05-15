> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `34.36`, mean = `292.49`, max = `934.97`, StdDev = `83.37`|
|latency percentile|50% = `299.01`, 75% = `338.69`, 95% = `422.91`, 99% = `492.54`|
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
|latency|min = `12.71`, mean = `99.61`, max = `238.43`, StdDev = `30.82`|
|latency percentile|50% = `99.9`, 75% = `117.89`, 95% = `150.14`, 99% = `183.42`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2700||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
