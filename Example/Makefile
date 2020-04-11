# Reemplazar por el nombre del directorio
APP_NAME		= sample-app
APP_DIR			= ./app
RELEASE_NAME	= release
DOCKER_REGISTRY = asajaroff
DOCKER_TAG		= v1.0.0

target:	run publish docker-build docker-run

run:
	dotnet run -p ${APP_DIR}

publish:
	dotnet publish ${APP_DIR} \
	-c ${RELEASE_NAME} \
	--no-self-contained


docker-build:
	docker build -t ${DOCKER_REGISTRY}/${APP_NAME}:${DOCKER_TAG} . \
	--build-arg RELEASE_NAME=${RELEASE_NAME}

docker-run:
	docker run ${DOCKER_REGISTRY}/${APP_NAME}:${DOCKER_TAG}

docker-publish:
	docker push ${DOCKER_REGISTRY}/${APP_NAME}:${DOCKER_TAG}
