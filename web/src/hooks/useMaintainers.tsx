import { Maintainer } from "../interfaces/Maintainer";
import { useApiData } from "./useApiData";

export const useMaintainers = () =>
  (useApiData<Maintainer[]>("/api/directory/maintainers") || []).sort(
    (a: Maintainer, b: Maintainer) => a.name.localeCompare(b.name)
  );
