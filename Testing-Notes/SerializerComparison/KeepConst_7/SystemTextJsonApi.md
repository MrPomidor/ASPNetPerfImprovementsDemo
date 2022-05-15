> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `65224`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `65224`, ok = `65224`, RPS = `362.4`|
|latency|min = `2.49`, mean = `19.29`, max = `102.05`, StdDev = `8.36`|
|latency percentile|50% = `18`, 75% = `23.49`, 95% = `34.85`, 99% = `45.82`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|65224||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `10678`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `10678`, ok = `10678`, RPS = `59.3`|
|latency|min = `10.7`, mean = `117.91`, max = `622.52`, StdDev = `82.83`|
|latency percentile|50% = `97.34`, 75% = `136.57`, 95% = `310.27`, 99% = `441.09`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|10678||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
