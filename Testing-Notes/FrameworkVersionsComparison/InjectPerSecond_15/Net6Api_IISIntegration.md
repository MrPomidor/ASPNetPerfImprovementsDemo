> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `119.68`, mean = `306.68`, max = `649.48`, StdDev = `64.93`|
|latency percentile|50% = `311.81`, 75% = `343.3`, 95% = `395.52`, 99% = `544.77`|
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
|latency|min = `27.41`, mean = `147.08`, max = `435.97`, StdDev = `38.96`|
|latency percentile|50% = `147.71`, 75% = `164.48`, 95% = `211.71`, 99% = `255.36`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2700||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
