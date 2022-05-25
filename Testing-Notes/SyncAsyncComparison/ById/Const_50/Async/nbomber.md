> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `1518706`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `1518706`, ok = `1518706`, RPS = `8437,3`|
|latency|min = `1,55`, mean = `5,91`, max = `165,37`, StdDev = `1,97`|
|latency percentile|50% = `5,62`, 75% = `6,74`, 95% = `8,99`, 99% = `11,54`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|1518706||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
