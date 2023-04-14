export function localeCompare({
  a,
  b,
}: { a?: string; b?: string } = {}): number {
  return a ? (b ? a.localeCompare(b) : -1) : 1;
}
