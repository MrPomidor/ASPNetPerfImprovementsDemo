> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `420488`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `420488`, ok = `420488`, RPS = `2336`|
|latency|min = `2,5`, mean = `21,39`, max = `217,96`, StdDev = `6,78`|
|latency percentile|50% = `19,58`, 75% = `24,46`, 95% = `33,7`, 99% = `43,26`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|420488||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `77190`, fail count: `13`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `77203`, ok = `77190`, RPS = `428,8`|
|latency|min = `8,13`, mean = `116,32`, max = `1009,34`, StdDev = `105,22`|
|latency percentile|50% = `83,84`, 75% = `108,03`, 95% = `367,87`, 99% = `553,98`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `77203`, fail = `13`, RPS = `0,1`|
|latency|min = `1002,51`, mean = `1008,66`, max = `1015,38`, StdDev = `4,3`|
|latency percentile|50% = `1008,13`, 75% = `1013,25`, 95% = `1014,78`, 99% = `1015,81`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|77190||
|-100|13|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
