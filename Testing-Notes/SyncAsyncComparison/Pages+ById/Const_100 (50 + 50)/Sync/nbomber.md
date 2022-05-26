> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `226311`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `226311`, ok = `226311`, RPS = `1257,3`|
|latency|min = `5,08`, mean = `39,74`, max = `121,8`, StdDev = `11,55`|
|latency percentile|50% = `39,39`, 75% = `47,55`, 95% = `59,2`, 99% = `67,46`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|226311||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `82837`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `82837`, ok = `82837`, RPS = `460,2`|
|latency|min = `21,4`, mean = `108,57`, max = `488,64`, StdDev = `53,49`|
|latency percentile|50% = `93,63`, 75% = `112,96`, 95% = `237,06`, 99% = `325,89`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|82837||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
