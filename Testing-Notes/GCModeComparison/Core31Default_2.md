> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `231002`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `231002`, ok = `231002`, RPS = `1283.3`|
|latency|min = `2.18`, mean = `7.77`, max = `72.37`, StdDev = `2.88`|
|latency percentile|50% = `7.24`, 75% = `9.12`, 95% = `13.02`, 99% = `17.39`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|231002||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
