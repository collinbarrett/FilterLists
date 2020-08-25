interface ArraySortableEntity {
  id: number;
  name: string;
}

export const arraySorter = (
  a: number[],
  b: number[],
  entities: ArraySortableEntity[]
) =>
  a && a.length
    ? b && b.length
      ? a.length === b.length
        ? entities
            .filter((e: ArraySortableEntity) => a.includes(e.id))
            .map((e: ArraySortableEntity) => e.name)
            .join()
            .toLowerCase() >
          entities
            .filter((e: ArraySortableEntity) => b.includes(e.id))
            .map((e: ArraySortableEntity) => e.name)
            .join()
            .toLowerCase()
          ? 1
          : -1
        : a.length > b.length
        ? -1
        : 1
      : -1
    : 1;
