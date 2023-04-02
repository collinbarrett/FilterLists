import { Software } from "../interfaces/Software";
import { useApiData } from "./useApiData";

export const useSoftware = () =>
  (useApiData<Software[]>("/api/directory/software") || []).sort(
    (a: Software, b: Software) => a.name.localeCompare(b.name)
  );
