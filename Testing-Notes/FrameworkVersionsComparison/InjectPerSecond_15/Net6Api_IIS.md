> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `2700`, fail count: `0`, all data: `0` MB MB

load simulation: `inject_per_sec`, rate: `15`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `2700`, ok = `2700`, RPS = `15`|
|latency|min = `36.5`, mean = `286.69`, max = `844.89`, StdDev = `83.59`|
|latency percentile|50% = `285.18`, 75% = `329.22`, 95% = `403.2`, 99% = `569.86`|
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
|latency|min = `16.26`, mean = `109.59`, max = `387.26`, StdDev = `39.46`|
|latency percentile|50% = `106.69`, 75% = `131.97`, 95% = `172.54`, 99% = `218.11`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|2700||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
