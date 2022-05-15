> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `230305`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `230305`, ok = `230305`, RPS = `1279.5`|
|latency|min = `2.1`, mean = `7.79`, max = `58.93`, StdDev = `2.9`|
|latency percentile|50% = `7.26`, 75% = `9.16`, 95% = `13.03`, 99% = `17.47`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|230305||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
