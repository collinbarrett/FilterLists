//https://stackoverflow.com/a/50470026/2343739
export const nameof = <T>(name: Extract<keyof T, string>) => name;