> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `108138`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `108138`, ok = `108138`, RPS = `600,8`|
|latency|min = `26,78`, mean = `166,33`, max = `729,18`, StdDev = `84,06`|
|latency percentile|50% = `142,59`, 75% = `170,5`, 95% = `368,64`, 99% = `508,67`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|108138||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
