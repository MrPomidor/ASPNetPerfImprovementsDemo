> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `395899`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `395899`, ok = `395899`, RPS = `2199,4`|
|latency|min = `2,6`, mean = `22,71`, max = `170,59`, StdDev = `8,03`|
|latency percentile|50% = `20,32`, 75% = `24,98`, 95% = `37,98`, 99% = `50,43`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|395899||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `69906`, fail count: `91`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `69997`, ok = `69906`, RPS = `388,4`|
|latency|min = `6,57`, mean = `127,31`, max = `1004,58`, StdDev = `117,68`|
|latency percentile|50% = `89,73`, 75% = `116,8`, 95% = `409,6`, 99% = `617,47`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `69997`, fail = `91`, RPS = `0,5`|
|latency|min = `999,68`, mean = `1007,38`, max = `1016,08`, StdDev = `4,73`|
|latency percentile|50% = `1007,62`, 75% = `1011,71`, 95% = `1014,78`, 99% = `1016,32`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|69906||
|-100|91|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
