> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `7480`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `7480`, ok = `7480`, RPS = `41.6`|
|latency|min = `18.67`, mean = `168.26`, max = `874.52`, StdDev = `118.1`|
|latency percentile|50% = `137.09`, 75% = `190.98`, 95% = `435.71`, 99% = `653.31`|
> status codes for scenario: `Orders`

|status code|count|message|
|---|---|---|
|200|7480||

> scenario: `Products`, duration: `00:03:00`, ok count: `42830`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `42830`, ok = `42830`, RPS = `237.9`|
|latency|min = `4.28`, mean = `29.39`, max = `126.94`, StdDev = `10.87`|
|latency percentile|50% = `27.98`, 75% = `34.56`, 95% = `49.22`, 99% = `65.06`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|42830||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
