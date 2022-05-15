> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `66749`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `66749`, ok = `66749`, RPS = `370.8`|
|latency|min = `3.09`, mean = `26.94`, max = `130.79`, StdDev = `11.09`|
|latency percentile|50% = `25.2`, 75% = `32.69`, 95% = `47.46`, 99% = `62.18`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|66749||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `11320`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `11320`, ok = `11320`, RPS = `62.9`|
|latency|min = `10.59`, mean = `158.88`, max = `728.66`, StdDev = `110.03`|
|latency percentile|50% = `133.12`, 75% = `188.03`, 95% = `400.13`, 99% = `583.68`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|11320||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
