module etconfig
open FSharp.Configuration

type ETConfig = YamlConfig<"config.yaml">
let config = ETConfig()
config.Load ".\config.yaml"

let mutable portalUrl = config.portalUrl.ToString()

let mutable i360HomeLogo = config.i360HomeLogo.ToString()

let mutable username = config.userId.ToString()
let mutable password = config.password.ToString()
