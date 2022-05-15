> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `6370`, fail count: `2`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `6372`, ok = `6370`, RPS = `35.4`|
|latency|min = `38.88`, mean = `197.29`, max = `1009.35`, StdDev = `152.77`|
|latency percentile|50% = `153.85`, 75% = `195.71`, 95% = `582.14`, 99% = `837.12`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `6372`, fail = `2`, RPS = `0`|
|latency|min = `1002.45`, mean = `1004.29`, max = `1006.12`, StdDev = `2.05`|
|latency percentile|50% = `1002.5`, 75% = `1006.59`, 95% = `1006.59`, 99% = `1006.59`|
> status codes for scenario: `Orders`

|status code|count|message|
|---|---|---|
|200|6370||
|-100|2|step timeout|

> scenario: `Products`, duration: `00:03:00`, ok count: `23770`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `23770`, ok = `23770`, RPS = `132.1`|
|latency|min = `8.37`, mean = `52.98`, max = `149.43`, StdDev = `13.73`|
|latency percentile|50% = `52.03`, 75% = `60.77`, 95% = `76.86`, 99% = `92.29`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|23770||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
