export interface OData<T> {
  "@odata.count": number | null;
  value: T;
}
