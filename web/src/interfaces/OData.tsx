export interface OData<T> {
  "@count": number | null;
  value: T[];
}
