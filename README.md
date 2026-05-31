# Extension Unity

Small Unity extension package with reusable helpers for gameplay and project code.

## Features

- `GameObject.DisableAfterSeconds(float seconds)` to deactivate a GameObject after a delay.
- UniTask-based async implementation with cancellation when the GameObject is destroyed.

## Requirements

- Unity 6000.4 or newer.
- [UniTask](https://github.com/Cysharp/UniTask), installed automatically through the package dependency.

## Installation

Install through Unity Package Manager from a Git URL:

```text
<repository-url>.git?path=Assets/Extension
```

Or add the package entry manually to `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.manhddm.extension": "<repository-url>.git?path=Assets/Extension"
  }
}
```

Replace `<repository-url>` with the URL of this repository.

## Usage

```csharp
using Extension.RunTime.Game;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void Start()
    {
        target.DisableAfterSeconds(2f);
    }
}
```

## Package Structure

```text
Assets/Extension/
  package.json
  RunTime/
    ExtensionUnity.asmdef
    Game/
      GameObjectExtension.cs
```

## Contributing

Issues and pull requests are welcome. Please read [CONTRIBUTING.md](CONTRIBUTING.md) before proposing changes.

## License

This project is licensed under the [MIT License](LICENSE).
