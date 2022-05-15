> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders`, duration: `00:03:00`, ok count: `4246`, fail count: `196`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `4442`, ok = `4246`, RPS = `23.6`|
|latency|min = `50.23`, mean = `241.09`, max = `1011.49`, StdDev = `164.77`|
|latency percentile|50% = `192.77`, 75% = `244.22`, 95% = `673.79`, 99% = `900.1`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `4442`, fail = `196`, RPS = `1.1`|
|latency|min = `999.45`, mean = `1045.02`, max = `3802.82`, StdDev = `269.51`|
|latency percentile|50% = `1011.2`, 75% = `1013.76`, 95% = `1027.58`, 99% = `2553.86`|
> status codes for scenario: `Orders`

|status code|count|message|
|---|---|---|
|200|4246||
|-100|196|step timeout|

> scenario: `Products`, duration: `00:03:00`, ok count: `17292`, fail count: `129`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `17421`, ok = `17292`, RPS = `96.1`|
|latency|min = `5.29`, mean = `63.29`, max = `1013.67`, StdDev = `35.11`|
|latency percentile|50% = `63.55`, 75% = `75.46`, 95% = `99.01`, 99% = `134.91`|

|step|fail stats|
|---|---|
|name|`getProductsPage`|
|request count|all = `17421`, fail = `129`, RPS = `0.7`|
|latency|min = `999.62`, mean = `1069.19`, max = `2522.99`, StdDev = `276.59`|
|latency percentile|50% = `1011.71`, 75% = `1012.74`, 95% = `1027.58`, 99% = `2523.14`|
> status codes for scenario: `Products`

|status code|count|message|
|---|---|---|
|200|17292||
|-100|129|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders|Step 'getOrdersPage' in scenario 'Orders' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Products|Step 'getProductsPage' in scenario 'Products' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
