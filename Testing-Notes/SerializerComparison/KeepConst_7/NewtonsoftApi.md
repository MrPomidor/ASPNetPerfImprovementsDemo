> test suite: `nbomber_default_test_suite_name`

> test name: `nbomber_default_test_name`

> scenario: `Orders by Id`, duration: `00:03:00`, ok count: `54083`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrder`|
|request count|all = `54083`, ok = `54083`, RPS = `300.5`|
|latency|min = `2.58`, mean = `23.28`, max = `280.54`, StdDev = `10.34`|
|latency percentile|50% = `21.78`, 75% = `28.56`, 95% = `40.83`, 99% = `52.77`|
> status codes for scenario: `Orders by Id`

|status code|count|message|
|---|---|---|
|200|54083||

> scenario: `Orders page`, duration: `00:03:00`, ok count: `8792`, fail count: `0`, all data: `0` MB MB

load simulation: `keep_constant`, copies: `7`, during: `00:03:00`
|step|ok stats|
|---|---|
|name|`getOrdersPage`|
|request count|all = `8792`, ok = `8792`, RPS = `48.8`|
|latency|min = `25.09`, mean = `143.24`, max = `783.42`, StdDev = `98.38`|
|latency percentile|50% = `116.03`, 75% = `156.67`, 95% = `377.6`, 99% = `543.74`|
> status codes for scenario: `Orders page`

|status code|count|message|
|---|---|---|
|200|8792||

> hints:

|source|name|hint|
|---|---|---|
|Scenario|Orders by Id|Step 'getOrder' in scenario 'Orders by Id' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
|Scenario|Orders page|Step 'getOrdersPage' in scenario 'Orders page' didn't track data transfer. In order to track data transfer, you should use Response.Ok(sizeInBytes: value)|
