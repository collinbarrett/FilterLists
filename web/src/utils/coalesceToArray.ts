export const coalesceToArray = <T>(input: T | T[]): T[] =>
  Array.isArray(input) ? input : [input];
