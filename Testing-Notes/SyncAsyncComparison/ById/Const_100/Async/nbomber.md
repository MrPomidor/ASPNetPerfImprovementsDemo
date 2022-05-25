> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `1605713`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `1605713`, ok = `1605713`, RPS = `8920,6`|
|latency|min = `1,54`, mean = `11,2`, max = `168,47`, StdDev = `3,67`|
|latency percentile|50% = `10,67`, 75% = `12,94`, 95% = `17,36`, 99% = `21,76`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|1605713||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
