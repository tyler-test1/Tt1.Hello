# Use to take passed string and break out the majorVersion, minorVersion, patchVersion, and suffixVersion components

param(
	[string] $dirtyVersionString = $(throw "Please specify a string to parse the version components from."),
	[string] $majorVersionOutName = "majorVersion",
	[string] $minorVersionOutName = "minorVersion",
	[string] $patchVersionOutName = "patchVersion",
	[string] $suffixVersionOutName = "suffixVersion"
)

$verMatches = [Regex]::Matches($dirtyVersionString, '0*(?<majorVersion>\d+)\.0*(?<minorVersion>\d+)\.0*(?<patchVersion>\d+)([-\.](?<suffixVersion>[\w\.-]+))?')

$majorVersion = $verMatches[0].Groups["majorVersion"]
$minorVersion = $verMatches[0].Groups["minorVersion"]
$patchVersion = $verMatches[0].Groups["patchVersion"]
$suffixVersion = $verMatches[0].Groups["suffixVersion"]

# Write the variables to the Azure agent environment
Write-Host "##vso[task.setvariable variable=$majorVersionOutName]$majorVersion"
Write-Host "##vso[task.setvariable variable=$minorVersionOutName]$minorVersion"
Write-Host "##vso[task.setvariable variable=$patchVersionOutName]$patchVersion"
Write-Host "##vso[task.setvariable variable=$suffixVersionOutName]$suffixVersion"

[pscustomobject]@{
	MajorVersion = $majorVersion
	MinorVersion = $minorVersion
	PatchVersion = $patchVersion
	SuffixVersion = $suffixVersion
}