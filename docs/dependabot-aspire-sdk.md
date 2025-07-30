# Dependabot Configuration for Aspire SDK Updates

This configuration addresses issue #5035 by implementing a comprehensive solution for managing Aspire SDK version updates through Dependabot.

## Problem
Dependabot automatically updates NuGet `<PackageReference>` elements but does not update MSBuild `<Sdk>` elements like:
```xml
<Sdk Name="Aspire.AppHost.Sdk" Version="9.3.0"/>
```

## Solution Components

### 1. Central Package Management (CPM)
**File**: `services/Directory.Build.props`
```xml
<ItemGroup>
    <PackageVersion Include="Aspire.AppHost.Sdk" Version="9.3.0" />
</ItemGroup>
```
- Centralizes the SDK version in a discoverable location
- Makes the version visible to Dependabot's nuget ecosystem scanner
- Follows .NET best practices for version management

### 2. Enhanced Dependabot Configuration
**File**: `.github/dependabot.yml`
```yaml
- package-ecosystem: "nuget"
  directory: "services"
  schedule:
    interval: "daily"
  allow:
    - dependency-type: "all"
  ignore: []
```
- Explicitly enables all dependency types
- Ensures Dependabot scans for Central Package Management files
- Positions the project for future Dependabot SDK support

### 3. Automated Version Sync Verification
**File**: `.github/workflows/check-aspire-versions.yml`
- Automatically checks that SDK and CPM versions match
- Runs on all relevant file changes
- Provides clear error messages when versions are out of sync
- Lists all Aspire package versions for comprehensive overview

## How It Works

### Current State (Partial Automation)
1. Dependabot updates the `PackageVersion` in `Directory.Build.props`
2. Manual sync required: Update the `<Sdk>` version in `FilterLists.AppHost.csproj`
3. GitHub Action verifies versions are consistent

### Future State (Full Automation Goal)
When Dependabot adds full SDK support, both versions will update automatically.

## Usage Instructions

### For Dependabot Updates
1. **When Dependabot creates a PR** for `Aspire.AppHost.Sdk` in `Directory.Build.props`:
   - Review the PR
   - Manually update the matching version in `services/FilterLists.AppHost/FilterLists.AppHost.csproj`
   - The GitHub Action will verify consistency

### For Manual Updates
1. Update version in `services/Directory.Build.props`
2. Update matching version in `services/FilterLists.AppHost/FilterLists.AppHost.csproj`
3. The build and GitHub Action will verify everything is correct

## Benefits
- **Centralized Management**: Single source of truth for SDK versions
- **Dependabot Visibility**: SDK versions are now discoverable by Dependabot
- **Automated Verification**: GitHub Action prevents version mismatches
- **Future-Proof**: Ready for when Dependabot adds full SDK support
- **Consistent Practices**: Follows .NET Central Package Management patterns

## Verification
The solution can be tested by:
1. Temporarily downgrading the SDK version in `Directory.Build.props`
2. Checking if Dependabot creates a PR to update it
3. Verifying the GitHub Action catches version mismatches

This configuration significantly improves the automation around Aspire SDK updates while providing safeguards and preparing for future Dependabot enhancements.