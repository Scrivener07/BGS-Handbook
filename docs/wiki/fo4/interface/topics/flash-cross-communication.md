# Cross Communication
Cross communication *directly * between menus is not possible in this way, such as `stage.focus(MessageBoxMenu)`.

Each root menu runs in something like an isolated container.
If your rooted into a menu such as `PauseMenu` or `HUDMenu`, then you would not be able to access members of any other rooted menu such as the vanilla `MessageBoxMenu`.
