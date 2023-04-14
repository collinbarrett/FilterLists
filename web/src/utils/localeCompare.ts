export const localeCompare = ({
  a,
  b,
}: { a?: string; b?: string } = {}): number =>
  a ? (b ? a.localeCompare(b) : -1) : 1;
