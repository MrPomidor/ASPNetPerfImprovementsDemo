> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `104273`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `104273`, ok = `104273`, RPS = `579,3`|
|latency|min = `35,17`, mean = `172,5`, max = `759,42`, StdDev = `87,43`|
|latency percentile|50% = `147,97`, 75% = `177,41`, 95% = `382,21`, 99% = `529,41`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|104273||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
