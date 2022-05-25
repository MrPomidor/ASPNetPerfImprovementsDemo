> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `106591`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `106591`, ok = `106591`, RPS = `592,2`|
|latency|min = `10,28`, mean = `84,38`, max = `397,77`, StdDev = `46,22`|
|latency percentile|50% = `71,3`, 75% = `88,32`, 95% = `195,07`, 99% = `271,36`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|106591||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
