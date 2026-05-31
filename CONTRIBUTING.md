# Contributing

Thank you for considering a contribution.

## Development Setup

1. Clone the repository.
2. Open the project with Unity.
3. Let Unity restore packages from `Packages/manifest.json`.
4. Make focused changes under `Assets/Extension`.

## Pull Requests

- Keep pull requests small and focused.
- Include a short explanation of the behavior change.
- Add or update examples and documentation when public APIs change.
- Verify the package imports cleanly in Unity before submitting.

## Coding Style

- Use C# with 4-space indentation.
- Keep runtime code under `Assets/Extension/RunTime`.
- Prefer APIs that are safe when Unity objects are destroyed.
- Avoid adding dependencies unless they provide clear value for package users.

## Versioning

This project uses semantic versioning. Public API additions, changes, and fixes should be reflected in `Assets/Extension/package.json` and `CHANGELOG.md`.
