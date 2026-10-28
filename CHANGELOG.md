# Changelog

## 1.0.0 — Unreleased

Version 1.0.0 targets net8.0 and netstandard2.1. It remains untagged until launch
and has not been published. The hosted API and console are not available yet.

### Authentication

- App-user sign-up, sign-in, password reset, TOTP MFA, and OAuth with PKCE S256.
- In-memory sessions or persistent sessions in an application-provided secure vault.
- Session revision checks prevent a pending refresh from replacing a newer session.
- Authentication-layer token errors refresh and retry eligible authenticated requests once.
- Sign-out revokes refresh credentials and reports persistent-store deletion failures.

### Data and functions

- Immutable queries with filters, selection, ordering, and inclusive ranges.
- Row and bulk writes, upserts, and equality-filtered counts.
- Function invocation preserves status, content, request ID, and duration. Completed function responses do not trigger authentication retries.

### Storage and realtime

- Sized uploads from 1 byte through 5 GiB, signed downloads, and bucket file listing and deletion.
- Signed asset transfers use caller cancellation without an implicit transfer timeout.
- WebSocket connections with subscription acknowledgments, bounded buffering, and explicit reconnects.
- Rejected subscriptions leave the connection usable. Queued events remain readable after closure.

### API coverage and transport

- The base URL must use HTTPS. HTTP is accepted only for `localhost`, `127.0.0.1` and `::1`; any other HTTP base URL throws `VaifException` with code `INVALID_URL`, so the API key and bearer token never travel in cleartext.
- 775 generated operations and 168 exclusions, each listed with its reason: 134 platform-staff operations and 34 routes without a typed success response.
- Platform-staff operations have no generated method, and calls to them fail with `STAFF_ONLY` before transport. Dot-segment path values are rejected locally.
- Redirect and cookie restrictions apply to both assemblies. Signed URL queries are omitted from transfer errors.
- Configurable API send timeout defaults to 100 seconds; caller cancellation remains OperationCanceledException.
- Invalid response shapes and transport failures use SDK exceptions with stable codes.

### Distribution

- The netstandard2.1 assembly depends on System.Text.Json 8.0.5 or later; the net8.0 assembly has no package dependencies.
- XML API documentation for both assemblies and standalone CI with dependency vulnerability checks.
- Deterministic builds, SourceLink metadata, and symbols from the standalone repository's Git commit.
- Unity 2021.2+ native integration guidance. IL2CPP player validation and live API conformance remain release gates.
