# Giraffe Api

## Create from the base template

```bash
# install template if needed
dotnet new -i "giraffe-template::*"

# No view engine
dotnet new giraffe -V none
```

## Implementation

1. Added `ping` simple text handler
1. Tweaked the `handleGetHello` handler to accept parameter from `routef`
1. Added the POST handler that blows up, calling the default `errorHandler`
