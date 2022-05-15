> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `62656`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `62656`, ok = `62656`, RPS = `348.1`|
|latency|min = `3.51`, mean = `28.7`, max = `124.37`, StdDev = `11.54`|
|latency percentile|50% = `27.04`, 75% = `34.62`, 95% = `49.98`, 99% = `64.99`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|62656||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `10847`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `10847`, ok = `10847`, RPS = `60.3`|
|latency|min = `13.41`, mean = `165.78`, max = `820.99`, StdDev = `116.61`|
|latency percentile|50% = `136.96`, 75% = `194.05`, 95% = `426.75`, 99% = `629.76`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|10847||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
