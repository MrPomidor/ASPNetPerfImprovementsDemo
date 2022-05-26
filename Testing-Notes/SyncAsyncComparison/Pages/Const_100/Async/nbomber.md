> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders page`, duration: `00:03:00`, ok count: `102372`, fail count: `125`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `102497`, ok = `102372`, RPS = `568,7`|
|latency|min = `7,18`, mean = `174,41`, max = `1009,98`, StdDev = `164,42`|
|latency percentile|50% = `123,84`, 75% = `151,94`, 95% = `587,78`, 99% = `855,55`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `102497`, fail = `125`, RPS = `0,7`|
|latency|min = `999,72`, mean = `1007,64`, max = `1028,91`, StdDev = `5,26`|
|latency percentile|50% = `1007,62`, 75% = `1011,71`, 95% = `1014,78`, 99% = `1023,49`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|102372||
|-100|125|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
