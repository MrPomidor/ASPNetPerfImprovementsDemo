> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `65430`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `65430`, ok = `65430`, RPS = `363.5`|
|latency|min = `2.52`, mean = `19.23`, max = `99.9`, StdDev = `8.38`|
|latency percentile|50% = `17.97`, 75% = `23.5`, 95% = `34.72`, 99% = `45.47`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|65430||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `10709`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `10709`, ok = `10709`, RPS = `59.5`|
|latency|min = `11.76`, mean = `117.58`, max = `578.39`, StdDev = `81.94`|
|latency percentile|50% = `97.34`, 75% = `136.32`, 95% = `305.15`, 99% = `431.36`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|10709||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
