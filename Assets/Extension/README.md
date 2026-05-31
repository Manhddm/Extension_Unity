# Extension Unity

Reusable runtime extensions for Unity projects.

## Installation

Install this package from Unity Package Manager with a Git URL that points to the package path:

```text
<repository-url>.git?path=Assets/Extension
```

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

## License

MIT License. See [LICENSE.md](LICENSE.md).
