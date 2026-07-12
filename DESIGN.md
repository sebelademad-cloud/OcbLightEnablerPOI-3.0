# OcbLightEnablerPOI - Design Notes

## Goal

Allow players to interact with POI lights without enabling the World Editor.

## Design Principles

- Do not duplicate vanilla game code.
- Do not use reflection unless absolutely necessary.
- Prefer Harmony patches that alter conditions rather than replacing methods.
- Keep patches as small as possible.
- Preserve vanilla behaviour whenever possible.

## Current findings

### GetBlockActivationCommands

Vanilla:

cmds[0].enabled = _world.IsEditor() || isRuntimeSwitch;

### GetActivationText

Vanilla only returns text when `_world.IsEditor()` is true.

### OnBlockActivated

Vanilla only calls `updateLightState()` when `_world.IsEditor()` is true.

## Possible approaches

1. Prefix/Postfix patches
2. Harmony transpilers
3. Runtime switch emulation

## Decision

Pending implementation.