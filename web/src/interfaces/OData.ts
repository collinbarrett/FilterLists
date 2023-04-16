export interface OData<T> {
  value: T;
  "@odata.count": number | null;
}
