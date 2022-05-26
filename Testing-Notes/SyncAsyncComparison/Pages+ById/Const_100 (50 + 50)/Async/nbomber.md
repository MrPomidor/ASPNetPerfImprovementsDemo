> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `416928`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `416928`, ok = `416928`, RPS = `2316,3`|
|latency|min = `2,88`, mean = `21,57`, max = `178,14`, StdDev = `6,23`|
|latency percentile|50% = `19,95`, 75% = `23,87`, 95% = `33,98`, 99% = `41,95`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|416928||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `73776`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `73776`, ok = `73776`, RPS = `409,9`|
|latency|min = `6,94`, mean = `121,89`, max = `763,74`, StdDev = `110,13`|
|latency percentile|50% = `88,45`, 75% = `110,53`, 95% = `397,06`, 99% = `582,66`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|73776||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
