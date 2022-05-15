> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `51193`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `51193`, ok = `51193`, RPS = `284.4`|
|latency|min = `3.64`, mean = `35.14`, max = `389.37`, StdDev = `14.32`|
|latency percentile|50% = `33.5`, 75% = `42.62`, 95% = `59.65`, 99% = `75.9`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|51193||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `8998`, fail count: `2`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `10`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `9000`, ok = `8998`, RPS = `50`|
|latency|min = `22.72`, mean = `199.65`, max = `981.08`, StdDev = `142.71`|
|latency percentile|50% = `159.87`, 75% = `220.54`, 95% = `539.14`, 99% = `782.34`|

|step|fail stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `9000`, fail = `2`, RPS = `0`|
|latency|min = `1003.52`, mean = `1020.16`, max = `1037.17`, StdDev = `16.9`|
|latency percentile|50% = `1003.52`, 75% = `1037.31`, 95% = `1037.31`, 99% = `1037.31`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|8998||
|-100|2|step timeout|

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
