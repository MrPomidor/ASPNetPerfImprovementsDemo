> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `1561041`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `50`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `1561041`, ok = `1561041`, RPS = `8672,4`|
|latency|min = `1,56`, mean = `5,75`, max = `185,94`, StdDev = `2`|
|latency percentile|50% = `5,5`, 75% = `6,41`, 95% = `8,5`, 99% = `11,05`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|1561041||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
