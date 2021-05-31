import { License } from "../interfaces/License";
import { useApiData } from "./useApiData";

export const useLicenses = () =>
  (useApiData<License[]>("/api/directory/licenses") || []).sort(
    (a: License, b: License) => a.name.localeCompare(b.name)
  );
