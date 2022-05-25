> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `105554`, fail count: `20`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `105574`, ok = `105554`, RPS = `586,4`|
|latency|min = `7,92`, mean = `170,18`, max = `1009,21`, StdDev = `161,54`|
|latency percentile|50% = `120,38`, 75% = `147,71`, 95% = `574,46`, 99% = `840,7`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `105574`, fail = `20`, RPS = `0,1`|
|latency|min = `999,25`, mean = `1006,82`, max = `1015`, StdDev = `5,26`|
|latency percentile|50% = `1004,54`, 75% = `1012,74`, 95% = `1014,78`, 99% = `1015,3`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|105554||
|-100|20|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
