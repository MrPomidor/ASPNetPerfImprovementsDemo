> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `1586820`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `1586820`, ok = `1586820`, RPS = `8815,7`|
|latency|min = `1,9`, mean = `11,33`, max = `98,7`, StdDev = `3,43`|
|latency percentile|50% = `10,82`, 75% = `13,04`, 95% = `17,44`, 99% = `21,79`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|1586820||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
