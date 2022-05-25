> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `1441163`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `100`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `1441163`, ok = `1441163`, RPS = `8006,5`|
|latency|min = `1,85`, mean = `12,48`, max = `187,51`, StdDev = `3,16`|
|latency percentile|50% = `12,34`, 75% = `13,71`, 95% = `17,2`, 99% = `20,91`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|1441163||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
