package tourism.api;

public interface SiteStore {

	boolean save(Site info);

	Site load(String name);

	static SiteStore open() {
		return new tourism.core.FileSiteStore();
	}
}

