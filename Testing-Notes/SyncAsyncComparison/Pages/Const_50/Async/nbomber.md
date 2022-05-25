> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `104317`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `104317`, ok = `104317`, RPS = `579,5`|
|latency|min = `7,6`, mean = `86,21`, max = `524,93`, StdDev = `74,74`|
|latency percentile|50% = `63,58`, 75% = `81,92`, 95% = `273,41`, 99% = `400,38`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|104317||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
